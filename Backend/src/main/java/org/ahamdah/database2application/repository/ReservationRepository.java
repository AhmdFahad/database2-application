package org.ahamdah.database2application.repository;

import org.ahamdah.database2application.model.Reservation;
import org.ahamdah.database2application.model.Room;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ReservationRepository extends JpaRepository<Reservation,Long> {
}
