#include "mainwindow.h"
#include <QTextEdit>
#include <QWidget>
#include <QApplication>
#include <QFile>
#include "syntaxhighligghter.h"
int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    //создаем текст и текстовое поле
    QTextEdit txt;
    //задаем шрифт и его размер
    QFont font("lucida Console", 9 , QFont::Normal);
    txt.document()->setDefaultFont(font);
    //создание документа
    new SyntaxHighLigghter(txt.document));
    return a.exec();
    //класс управления цветами синтаксиса
    QPalette pal = txt.palette();
    //базовй цвет темный
    pal.setColor(QPalette::Base, Qt::darkCyan);
    pal.setColor(QPalette::Text, Qt:: darkGreen);

    txt.show();
    txt.resize(640, 480);

    //подклчение файла
    QFile file(":/SyntaxHighLighter.cpp");
    file.open(QFile::ReadOnly);
    //чтение техста
    txt.setPlainText(QLatin1String(file.readAll()));
    return a.exec();

}
