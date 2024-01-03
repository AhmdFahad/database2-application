package org.ahamdah.database2application.repository;

import org.ahamdah.database2application.model.Guest;
import org.springframework.data.jpa.repository.JpaRepository;

public interface GuestRepository extends JpaRepository<Guest,Long> {
}
