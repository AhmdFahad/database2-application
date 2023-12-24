package org.ahamdah.database2application.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

import java.util.Date;

@Getter
@Setter
@Entity
@Table(name = "reservation")
public class Reservation {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id", nullable = false)
    private Long id;

    @Temporal(TemporalType.DATE)
    @Column(name = "check_i_out_date", nullable = false)
    private Date checkIOutDate;

    @Temporal(TemporalType.DATE)
    @Column(name = "check_in_date", nullable = false)
    private Date checkInDate;

    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "guest_guest_id")
    private Guest guest;

    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "staff_id")
    private Staff staff;

    @OneToOne(orphanRemoval = true)
    @JoinColumn(name = "room_id")
    private Room room;

}