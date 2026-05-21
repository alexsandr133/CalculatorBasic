 #include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QTextEdit>
#include <QStatusBar>
#include <QtGui>
#include <QTextStream>
#include <QDebug>
#include <QFile>
#include <QMessageBox>
#include <QFileDialog>
//конструктор

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}



//сигналы методов
//пользователь вводит текст ии он менеятся


MainWindow::~MainWindow()
{
    delete ui;
}
/*
  логика кода
  у нас есть поле ввода пользователь вводит какой то код
  и правит его.
  дальше его выбор сохранить или же отправить открывается обзор проводник и место сохраниенния и пользователь выбирает папку

*/
//ui-> setupUi(this);
//обработка ввода польззователя
void operationEntered()
{
    //получаем текст из ввода

    QTextEdit*  Console = new QTextEdit("&Code");
    //задаем шрифт и его размер
    QFont font("lucida console",9,QFont::Normal);
    //ширина линии вввода консоли
    Console->setLineWidth(50);
    //запись в поле ввода
    QTextEdit* code = new QTextEdit;
    //заносим код в волеввода
    QObject::connect(code, &QTextEdit::textChanged,  [ code, Console](){
        //прикаждом иизменении текста изменям
        QString currentText = code->toPlainText();
        //устанавливаем его в console
        Console->setPlainText(currentText);

    });

}
//void MainWindow:: OperationSaved()
//{
    //QTextEdit*  Console = new QTextEdit("&Code");
    //задаем шрифт и его размер
    //QFont font("lucida console",9,QFont::Normal);
    //ширина линии вввода консоли
    //Console->setLineWidth(50);


    //пытаемся открыть файл для полного чтения
    //QFile file;
    //file.setFileName("file.txt");
    //if (!file.open(QIODevice::WriteOnly))
    //{
        //qDebug() <<"file is open";
    //}
    //file.close();

    //читаем файл
    //QTextStream in(&file);
    //in.setEncoding(QStringConverter::Utf8);
    //QString content  = in.readAll();
    //file.close();

    //переносим все в консоль
    //Console->setPlainText(content);
    //сохраняем файл после текста
    //QString filename = QFileDialog::getSaveFileName(nullptr, "Save As","");
    //if (!filename.isEmpty())
    //{
        //QFile file(filename);
        //if (file.open(QIODevice::WriteOnly | QIODevice::Text))
        //{
            //QTextStream fileReadAll(&file)
                //QMessageBox::about(nullptr,"успех",filename);

        //}
        //file.close();
    //}



    //QWidget::connect(ui->savebutton, &QPushButton::clicked,  this , &MainWindow::OperationSaved);
//}
//сохраняем файл после текста
