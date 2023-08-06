package com.sahibinden.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.sahibinden.entity.Agent;

@Repository
public interface AgentRepository extends JpaRepository<Agent, Integer> {

}
