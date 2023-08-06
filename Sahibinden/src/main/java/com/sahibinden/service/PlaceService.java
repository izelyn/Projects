package com.sahibinden.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.sahibinden.entity.Place;
import com.sahibinden.repository.PlaceRepository;

@Service
public class PlaceService {

	@Autowired
	private PlaceRepository pRepo;

	public void save(Place p) {
		pRepo.save(p);
	}

	public List<Place> getAllPlace() {
		return pRepo.findAll();
	}

	public Place getPlaceById(int id) {
		return pRepo.findById(id).get();
	}

	public void deletePlaceById(int id) {
		pRepo.deleteById(id);
	}
}
