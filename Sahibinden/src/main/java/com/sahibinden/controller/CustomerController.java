package com.sahibinden.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;

import com.sahibinden.entity.Customer;
import com.sahibinden.service.CustomerService;

@Controller
public class CustomerController {

	@Autowired
	private CustomerService service;

	@GetMapping("/customer_register")
	public String customerRegister() {
		return "customerRegister";
	}

	@PostMapping("/save_customer")
	public String addCustomer(@ModelAttribute Customer c) {
		service.save(c);
		return "redirect:/place_screen";
	}

	@GetMapping("/available_customer")
	public ModelAndView getAllCustomer() {
		List<Customer> list = service.getAllCustomer();

		return new ModelAndView("customerList", "customer", list);
	}

	@RequestMapping("/delete_customer/{id}")
	public String deleteCustomer(@PathVariable("id") int id) {
		service.deleteCustomerById(id);
		return "redirect:/available_customer";
	}
}
