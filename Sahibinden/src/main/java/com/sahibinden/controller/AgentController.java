package com.sahibinden.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;

import com.sahibinden.entity.Agent;
import com.sahibinden.service.AgentService;

@Controller
public class AgentController {

	@Autowired
	private AgentService service;

	@GetMapping("/")
	public String Home() {
		return "Home";

	}

	@GetMapping("/agent_register")
	public String agentRegister() {
		return "agentRegister";
	}

	@PostMapping("/save_agent")
	public String addAgent(@ModelAttribute Agent a) {
		service.save(a);
		return "redirect:/customer_register";
	}

	@GetMapping("/available_agent")
	public ModelAndView getAllAgent() {
		List<Agent> list = service.getAllAgent();

		return new ModelAndView("agentList", "agent", list);
	}

	@RequestMapping("/delete_agent/{id}")
	public String deleteAgent(@PathVariable("id") int id) {
		service.deleteAgentById(id);
		return "redirect:/available_agent";
	}

}
