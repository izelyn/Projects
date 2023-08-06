package com.sahibinden.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import com.sahibinden.entity.Place;

@Repository
public interface PlaceRepository extends JpaRepository<Place, Integer> {

}
