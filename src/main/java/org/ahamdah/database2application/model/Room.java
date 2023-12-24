package org.ahamdah.database2application.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "room")
public class Room {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id", nullable = false)
    private Long id;

    @Column(name = "availability")
    private Boolean availability;

    @Column(name = "floor")
    private String floor;

    @Column(name = "type")
    private String type;

    @Column(name = "price")
    private Double price;

    @OneToOne(mappedBy = "room", orphanRemoval = true)
    private Reservation reservation;
}