package org.ahamdah.database2application.controller;

import org.ahamdah.database2application.model.Guest;
import org.ahamdah.database2application.repository.GuestRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@CrossOrigin
public class MainController {

    @Autowired
    public GuestRepository guestRepository;

    @PostMapping("")
    public void createGuest(@RequestBody Guest guest){
        guestRepository.save(guest);
    }
    @GetMapping("")
    public List<Guest> getAllGuest(){
        return guestRepository.findAll();
    }
}
