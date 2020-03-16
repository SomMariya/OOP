#pragma once
#include "pch.h"
#include "MainString.h"
#include <iostream>
using namespace std;

MainString::MainString()
{
    str = nullptr;
}

MainString::MainString(char* str)
{
    int len = 0;
    int i = 0;
    while (str[i] != '\0')
    {
        len++;
        i++;
    }
    this->str = new char[len + 1];
    for (int j = 0; j < len + 1; j++)
    {
        this->str[j] = str[j];
    }
    this->str[len] = '\0';
}

int MainString::strlength()
{
    int len = 0;
    if (str == nullptr)
    {
        return len;
    }
    while (str[len] != '\0')
    {
        len++;
    }
    return len;
}

bool MainString::check()
{
    return strlength() == 0;
}

int MainString::col_v_str()
{
    int i = 0;
    int col = 0;
    if (str == nullptr)
    {
        return col;
    }
    while (str[i] != '\0')
    {
        if (str[i] != ' ')
            col++;
        i++;
    }
    return col;
}

int MainString::col_z_str()
{
    int i = 0;
    int col = 0;
    if (str == nullptr)
    {
        return col;
    }
    while (str[i] != '\0')
    {
        if (str[i] >= '0' && str[i] <= '9')
            col++;
        i++;
    }
    return col;
}

int MainString::pr_v_str()
{
    int col = 0;
    float pr = 0;
    int i = col_v_str();
    col = col_z_str();
    if (col > 0)
    {
        pr = (100 * col) / i;
    }
    return pr;
}

bool MainString::same_str(MainString mainstr)
{
    int eq = 0;
    if (this->str == mainstr.str)
        return true;
    if (strlength() == mainstr.strlength())
    {
        for (int i = 0; i < strlength(); i++)
        {
            if (str[i] == mainstr.str[i])
                eq++;
        }
        if (eq == strlength())
            return true;
        else
            return false;
    }
    else
    {
        return false;
    }
}




