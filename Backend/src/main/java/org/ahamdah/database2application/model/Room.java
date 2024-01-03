package org.ahamdah.database2application.model;

import jakarta.persistence.*;
import lombok.*;

@Builder
@Data@AllArgsConstructor@NoArgsConstructor
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

    @OneToOne(orphanRemoval = true)
    @JoinColumn(name = "reservation_id")
    private Reservation reservation;

}