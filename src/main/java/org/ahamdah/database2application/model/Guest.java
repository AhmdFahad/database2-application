package org.ahamdah.database2application.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;


@Entity@Data
@AllArgsConstructor@NoArgsConstructor
@Builder
public class Guest {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "guest_id", nullable = false)
    private Long guestId;

    @Column(name = "name", nullable = false)
    private String name;

    @Column(name = "ssn", nullable = false, unique = true)
    private String ssn;

    @Column(name = "phone_number", unique = true)
    private String phoneNumber;

    @Column(name = "age")
    private Integer age;

    @Column(name = "email")
    private String email;


}
