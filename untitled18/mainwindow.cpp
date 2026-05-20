#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QTextEdit>
#include <QStatusBar>
#include <QtGui>
#include <QTextStream>
#include <QDebug>
#include <QFile>
#include <QMessageBox>
//статус веденного текста

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

QWidget::connect(code, signal(textChaged(const QStrings,Console, SLOT(const QStrings))));
QWidget::connect(savebutton, QPushButton::clicked, this , mainWindow(Text));
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

    QTextEdit*  Console = new QTextEdit;
    //задаем шрифт и его размер
    QFont font("lucida console",9,QFont::Normal);
    //ширина линии вввода консоли
    Console->setLineWidth(50);
    //запись в поле ввода
    QTextEdit* Console = new QLabel("&Code");
    QTextEdit* code = new QTextEdit;
    //заносим код в волеввода
    Console->setPlainText(code);
    QObject::connect(code, signal(textChaged(const QStrings,Console, SLOT(const QStrings))));
}
void operationSaved()
{

    //пытаемся открыть файл для полного чтения
    QFile file;
    file.setName("file.txt");
    if (!file.Open(QIODevice::WriteOnly))
    {
        qDebug() <<"file is open";
    }
    file.close();

    //читаем файл
    QTextStream in(&file);
    in.setEncoding(QStringConverter::Utf8);
    QString content  = in.readAll();
    file.close();

    //переносим все в консоль
    console->setPlainText(content);
    //сохраняем файл после текста
    if (Console->toPlainText().isEmperty)
    {
        QMessageBox::warning(this,"нечего сохранять пусто");
    }

    saveToFile();
}
//сохраняем файл после текста
