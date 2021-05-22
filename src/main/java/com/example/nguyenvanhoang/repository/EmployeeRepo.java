package com.example.nguyenvanhoang.repository;

import com.example.nguyenvanhoang.entity.EmployeeEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import java.util.List;

    interface ProductRepo extends JpaRepository<EmployeeEntity, Integer> {
    @Query("select p from EmployeeEntity p where p.name like %:name%")
    List<EmployeeEntity> findProductByName(String name);

    List<EmployeeEntity> findAllByCategoryidAndPrice(int id, int price);
}
