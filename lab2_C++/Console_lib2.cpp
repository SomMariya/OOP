#include <iostream>
#include"StaticLib2/MainString.h"
#include"StaticLib2/MyString.h"

using namespace std;

int main()
{
    char strA[100] = { 'L','o','n','d','o','n','1',' ','i','s','2',' ','t','h','e','3','\0' };
    char strB[100] = { 'c','a','p','i','t','a','l','\0' };

    MainString str1 = MainString(strA);
    MainString str2 = MainString(strB);
    MyString* text = new MyString();

    text->plus(str1);
    text->plus(str2);
    text->largest_str();
    text->pr_z_text();//процент цифр в тексте
    text->col_v_text();//кол-во символов в тексте
    text->delete_str(str1);
    text->clear();//очищение текста

    return 0;
}