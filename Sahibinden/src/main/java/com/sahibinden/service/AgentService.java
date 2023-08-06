package com.sahibinden.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.sahibinden.entity.Agent;
import com.sahibinden.repository.AgentRepository;

@Service
public class AgentService {

	@Autowired
	private AgentRepository aRepo;

	public void save(Agent a) {
		aRepo.save(a);
	}

	public List<Agent> getAllAgent() {
		return aRepo.findAll();
	}

	public void deleteAgentById(int id) {
		aRepo.deleteById(id);
	}

}
