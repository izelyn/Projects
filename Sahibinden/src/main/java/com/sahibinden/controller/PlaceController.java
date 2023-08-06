package com.sahibinden.controller;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;
import com.sahibinden.service.PlaceService;
import com.sahibinden.entity.Place;

@Controller
public class PlaceController {

	@Autowired
	private PlaceService service;

	@GetMapping("/place_register")
	public String placeRegister() {
		return "placeRegister";
	}

	@GetMapping("/place_screen")
	public String PlaceScreen() {
		return "placeScreen";
	}

	@GetMapping("/available_place")
	public ModelAndView getAllPlace() {
		List<Place> list = service.getAllPlace();

		return new ModelAndView("placeList", "place", list);
	}

	@PostMapping("/save_place")
	public String addPlace(@ModelAttribute Place p) {
		service.save(p);
		return "redirect:/available_place";
	}

	@GetMapping("/{id}")
	public String getMyList(@PathVariable("id") int id, Model model) {
		Place p = service.getPlaceById(id);
		model.addAttribute("place", p);
		return "placepage";
	}

	@RequestMapping("/delete_place/{id}")
	public String deletePlace(@PathVariable("id") int id) {
		service.deletePlaceById(id);
		return "redirect:/available_place";
	}

}
