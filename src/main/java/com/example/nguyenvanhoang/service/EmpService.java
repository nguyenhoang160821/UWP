package com.example.nguyenvanhoang.service;


import com.example.nguyenvanhoang.entity.EmployeeEntity;

import java.util.List;

    public interface EmpService {
    List<EmployeeEntity> getAll();
    EmployeeEntity createProduct(EmployeeEntity p);
    void deleteProduct(int id);
    EmployeeEntity updateProduct(EmployeeEntity p);
    List<EmployeeEntity> getProductByName(String name);
}
