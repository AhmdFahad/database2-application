package org.ahamdah.database2application.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "review")
public class Review {
    @Id
    @Column(name = "id", nullable = false)
    private Long id;

    @Column(name = "rating", nullable = false)
    private Integer rating;

    @Column(name = "comment")
    private String comment;

    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "guest_guest_id")
    private Guest guest;

}