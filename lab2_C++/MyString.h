#pragma once
#include"MainString.h"
#include"pch.h"
#include<iostream>
using namespace std;

class MyString
{
private:
    int len1 = 10;
    int str_nums = 0;
    MainString* text = new MainString[len1];
public:
    void clear();
    void plus(MainString string);
    int col_v_text();
    int col_z_text();
    int pr_z_text();
    void delete_str(MainString string);
    MainString largest_str();
};

