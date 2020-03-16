#pragma once
#include"pch.h"
#include <iostream>
using namespace std;

class MainString
{
private:
    char* str;

public:
    MainString();

    MainString(char* str);

    int strlength();
    bool check();
    int col_v_str();
    int col_z_str();
    int pr_v_str();
    bool same_str(MainString mainstr);

};



