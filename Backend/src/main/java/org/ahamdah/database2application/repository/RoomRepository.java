package org.ahamdah.database2application.repository;

import org.ahamdah.database2application.model.Guest;
import org.ahamdah.database2application.model.Room;
import org.springframework.data.jpa.repository.JpaRepository;

public interface RoomRepository extends JpaRepository<Room,Long> {
}
