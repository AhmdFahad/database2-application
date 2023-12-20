package org.ahamdah.database2application.model;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "room")
public class Room {
    @Id
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

}