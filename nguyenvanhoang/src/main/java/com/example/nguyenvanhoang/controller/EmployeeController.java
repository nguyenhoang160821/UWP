package com.example.nguyenvanhoang.controller;

import com.example.nguyenvanhoang.entity.EmployeeEntity;
import com.example.nguyenvanhoang.service.empSevice;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.stereotype.Service;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

import java.util.List;
@Service
@Controller
public class EmployeeController {

    @Autowired
    EmpSevice empSevice;

    @GetMapping({"/", "/index"})
    public String index(Model model) {
        String msg = "Hello Spring Boot + JSP";
        model.addAttribute("msg", msg);
        List<EmployeeEntity> products = empSevice.getAll();
        model.addAttribute("products", products);
        return "index";
    }
}
