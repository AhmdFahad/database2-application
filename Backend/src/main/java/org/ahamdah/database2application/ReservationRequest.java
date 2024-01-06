package org.ahamdah.database2application;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.Date;

@Data@AllArgsConstructor@NoArgsConstructor
@Builder
public class ReservationRequest {
    private Date checkOutDate;
    private Date checkInDate;
    private Long userId;
    private Long roomID;

}
