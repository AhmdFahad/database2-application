package org.ahamdah.database2application;

import org.ahamdah.database2application.model.Guest;
import org.ahamdah.database2application.model.Room;
import org.ahamdah.database2application.model.Staff;
import org.ahamdah.database2application.repository.GuestRepository;
import org.ahamdah.database2application.repository.StaffRepositroy;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.AutoConfigureOrder;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class Database2Application  implements CommandLineRunner{

    public static void main(String[] args) {
        SpringApplication.run(Database2Application.class, args);
    }

    @Autowired
    GuestRepository guestRepository;

    @Autowired
    StaffRepositroy staffRepositroy;
    @Override
    public void run(String... args) throws Exception {
        var x=Guest.builder().
                name("ahmed").
                ssn("12345").
                phoneNumber("078432432").
                email("Ahmed@Gmail.com").
                age(20).
                build();
        guestRepository.save(x);

//        var room= Room.builder().
//                floor("1").
//                availability(true).
//                price(123.3).
//                build();
//        guestRepository.save(x);
//
        var staff= Staff.builder().
                phone("12312313312312").
                position("Manager").
                name("Ahmed").
                email("Ahmad@Gmail.com").
                build();
        staffRepositroy.save(staff);
    }
}
