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
@Table(name = "bill")
public class Bill {
    @Id
    @Column(name = "id", nullable = false)
    private Long id;

    @Column(name = "total_amount")
    private String totalAmount;

    @Column(name = "payment_method")
    private String paymentMethod;

    @Column(name = "payment_status")
    private String paymentStatus;

}