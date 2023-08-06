package com.sahibinden.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.sahibinden.entity.Customer;
import com.sahibinden.repository.CustomerRepository;

@Service
public class CustomerService {

	@Autowired
	private CustomerRepository cRepo;

	public void save(Customer c) {
		cRepo.save(c);
	}

	public List<Customer> getAllCustomer() {
		return cRepo.findAll();
	}

	public void deleteCustomerById(int id) {
		cRepo.deleteById(id);
	}
}
