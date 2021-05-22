package com.example.nguyenvanhoang.service;

import com.example.nguyenvanhoang.entity.EmployeeEntity;
import com.example.nguyenvanhoang.repository.EmployeeRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ProductServiceImpl implements EmpService{

    @Autowired
    EmployeeRepo employeeRepo;

    @Override
    public List<EmployeeEntity> getAll() {
        return employeeRepo.findAll();
    }

    @Override
    public EmployeeEntity createProduct(EmployeeEntity p) {
        return employeeRepo.save(p);
    }

    @Override
    public void deleteProduct(int id) {
        employeeRepo.deleteById(id);
    }

    @Override
    public EmployeeEntity updateProduct(EmployeeEntity p) {
        return employeeRepo.save(p);
    }

    @Override
    public List<EmployeeEntity> getProductByName(String name) {
        List<EmployeeEntity> list = employeeRepo.findProductByName(name);
        return list;
    }
}
