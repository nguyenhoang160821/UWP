package com.example.nguyenvanhoang.entity;

import javax.persistence.*;
import java.util.List;

@Entity
@Table(name = "emp")
public class EmployeeEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    @Column(name = "name")
    private String name;

    @Column(name = "wage")
    private int wege;
    @OneToMany(mappedBy = "emp")
    private List<EmployeeEntity> products;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

}
