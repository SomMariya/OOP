#include "MainString.h"
#include"pch.h"
#include"MyString.h"
#include<iostream>
using namespace std;

void MyString::clear()
{
    for (int i = 0; i < len1; i++)
    {
        text[i] = MainString();
    }
}

void MyString::plus(MainString string)
{
    if (!text[len1 - 1].check())
    {
        len1 = (3 * len1) / 2 + 1;
        MainString* newtext = new MainString[len1];
        for (int i = 0; i < str_nums; i++)
        {
            newtext[i] = text[i];
        }
        text = newtext;
    }
    text[str_nums] = string;
    str_nums++;
}

int MyString::col_v_text()
{
    int col2 = 0;
    for (int i = 0; i < str_nums; i++)
    {
        col2 += text[i].col_v_str();
    }
    return col2;
}

int MyString::col_z_text()
{
    int col = 0;
    for (int i = 0; i < str_nums; i++)
    {
        col += text[i].col_z_str();
    }
    return col;
}

int MyString::pr_z_text()
{
    int col = 0, col1 = 0;
    int pr = 0;
    col = col_v_text();
    col1 = col_z_text();
    pr = 100 * col1 / col;
    return pr;
}

void MyString::delete_str(MainString string)
{
    int indx = 0;
    int i = 0;
    while (i < str_nums && !string.same_str(text[i]))
    {
        indx = i;
        i++;
    }
    for (int j = indx; j < str_nums; j++)
    {
        text[j] = text[j + 1];
    }
    text[str_nums] = MainString();
    str_nums--;
}

MainString MyString::largest_str()
{
    MainString newstring;
    int max_len = 0;
    for (int i = 0; i < str_nums; i++)
    {
        if (text[i].strlength() > max_len)
        {
            max_len = text[i].strlength();
            newstring = text[i];
        }
    }
    return newstring;
}