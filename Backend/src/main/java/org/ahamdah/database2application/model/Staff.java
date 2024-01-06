package org.ahamdah.database2application.model;

import jakarta.persistence.*;
import lombok.*;

@Entity
@AllArgsConstructor@NoArgsConstructor
@Builder@Data
@Table(name = "staff")
public class Staff {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id", nullable = false)
    private Long id;

    @Column(name = "name")
    private String name;

    @Column(name = "phone")
    private String phone;

    @Column(name = "position")
    private String position;

    @Column(name = "email")
    private String email;

}