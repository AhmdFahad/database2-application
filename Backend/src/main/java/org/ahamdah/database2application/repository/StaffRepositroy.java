package org.ahamdah.database2application.repository;


import org.ahamdah.database2application.model.Staff;
import org.springframework.data.jpa.repository.JpaRepository;

public interface StaffRepositroy extends JpaRepository<Staff,Long> {
}
