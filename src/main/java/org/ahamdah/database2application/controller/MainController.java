package org.ahamdah.database2application.controller;

import org.ahamdah.database2application.model.Guest;
import org.ahamdah.database2application.repository.GuestRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GuestController {

    @Autowired
    public GuestRepository guestRepository;

    @PostMapping
    public void createGuest(@RequestBody Guest guest){
        guestRepository.save(guest);
    }

}
