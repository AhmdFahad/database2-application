package org.ahamdah.database2application.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "amenities")
public class Amenities {
    @Id
    @Column(name = "id", nullable = false)
    private Long id;

    @Column(name = "name")
    private String name;

    @Column(name = "desciption")
    private String desciption;

    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "room_id")
    private Room room;

}