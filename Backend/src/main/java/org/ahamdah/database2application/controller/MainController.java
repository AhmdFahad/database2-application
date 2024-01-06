package org.ahamdah.database2application.controller;

import jdk.swing.interop.SwingInterOpUtils;
import lombok.RequiredArgsConstructor;
import org.ahamdah.database2application.ReservationRequest;
import org.ahamdah.database2application.model.Guest;
import org.ahamdah.database2application.model.Reservation;
import org.ahamdah.database2application.model.Room;
import org.ahamdah.database2application.repository.GuestRepository;
import org.ahamdah.database2application.repository.ReservationRepository;
import org.ahamdah.database2application.repository.RoomRepository;
import org.ahamdah.database2application.repository.StaffRepositroy;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@CrossOrigin
public class MainController {
    @Autowired
    public GuestRepository guestRepository;
    @Autowired
    public RoomRepository roomRepository;
    @Autowired
    public ReservationRepository reservationRepository;
    @Autowired
    public StaffRepositroy staffRepositroy;

    @PostMapping("/guest")
    public void createGuest(@RequestBody Guest guest){
        guestRepository.save(guest);
    }
    @GetMapping("/guest")
    public List<Guest> getAllGuest(){
        return guestRepository.findAll();
    }

    @GetMapping("/reservation")
    public List<Reservation> getAllReservation(){
        return reservationRepository.findAll();
    }
    @PostMapping("/reservation2")
    public Reservation createReservation(@RequestBody ReservationRequest reservationRequest){
        var room=roomRepository.findById(reservationRequest.getRoomID()).get();
        var reservation =Reservation.builder().
        checkOutDate(reservationRequest.getCheckOutDate()).
        checkInDate(reservationRequest.getCheckInDate()).
        room(room).
        guest(guestRepository.findById(reservationRequest.getUserId()).get()).
                build();
        room.setAvailability(false);
        roomRepository.save(room);
        return reservationRepository.save(reservation);
    }
    @PostMapping("/reservation")
    public Reservation createReservation(@RequestBody Reservation reservation) {
        return reservationRepository.save(reservation);
    }

    @GetMapping("/room")
    public List<Room> getAllRoom(){
        return roomRepository.findAll();
    }


}
