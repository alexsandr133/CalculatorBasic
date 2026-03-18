#include "mainwindow.h"
#include "ui_mainwindow.h"
//назначпем переменные для работы программы
double firstNumber = 0;
double secondNumber = 0;
QString currentoperation= " ";
bool isWaitiongForSecondNumber = false;
//пеередаем сигналы и описываем кнопки
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    /*
     синтаксис вызова сигнала:
     connect(ui->название кнопки,QPushButton,this,название виджета, вызываемый сигнал
     при запуске программы при нажатиии кнопки вызывается сигнал и у нас работают кнопки калькулятора.
     сигналы которые есть у нас в коде:
     digitPressed
     operationPressed
     calculate
    */
    connect(ui->button_0,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_1,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_2,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_3,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_4,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_5,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_6,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_7,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_8,&QPushButton::clicked, this, &MainWindow::digitPressed);
    connect(ui->button_9,&QPushButton::clicked, this, &MainWindow::digitPressed);

    connect(ui->button_plus, &QPushButton::clicked, this, &MainWindow::operationPressed);
    connect(ui->button_minus, &QPushButton::clicked, this, &MainWindow::operationPressed);
    connect(ui->button_c,&QPushButton::clicked, this, &MainWindow::operationPressed);
    connect(ui->button_mulnition, &QPushButton::clicked, this, &MainWindow::operationPressed);
    connect(ui->button_delenie, &QPushButton::clicked, this, &MainWindow::operationPressed);
    connect(ui->button_point,&QPushButton::clicked, this, &MainWindow::operationPressed);
    connect(ui->button_procent,&QPushButton::clicked, this, &MainWindow::operationPressed);


    connect(ui->equalButton, &QPushButton::clicked, this, &MainWindow::calculate);
    connect(ui->button_c,&QPushButton::clicked, this, &MainWindow::pressedClean);
    connect(ui->button_point,&QPushButton::clicked, this, &MainWindow::returnNumbersFloat);


}

MainWindow::~MainWindow()
{
    delete ui;
}
void MainWindow::operationPressed()
{
    QPushButton *button = (QPushButton*)sender();
    QString operation = button->text();
    firstNumber = ui->display->text().toDouble();
    currentoperation = operation;
    if (operation=="." && !isWaitiongForSecondNumber)
    {   double result = 0;
        firstNumber = ui->display->text().toDouble();
        isWaitiongForSecondNumber = false;
        QString display = QString::number(firstNumber) + operation;

        ui->display->setText(display);
        return;

    }
    if (isWaitiongForSecondNumber){
        ui->display->setText("0");

    }
    isWaitiongForSecondNumber = true;


}
void MainWindow::calculate()
{

    secondNumber = ui->display->text().toDouble();
    double result = 0;
    if (currentoperation =="+")
    {
        result = firstNumber + secondNumber;
    }
    else if(currentoperation=="-")
    {
        result = firstNumber - secondNumber;
    }
    else if(currentoperation=="*")
    {
        result = firstNumber * secondNumber;
    }
    else if(currentoperation=="/")
    {
        result = firstNumber / secondNumber;
    }
    ui->display->setText(QString::number(result));

}
void MainWindow::digitPressed()
{
    QPushButton *button = (QPushButton*)sender();
    QString digit = button->text();
    QString display = ui->display->text();
    if (display =="0")
    {
        display ="";
    }

    display +=digit;
    ui->display->setText(display);
}
void MainWindow::pressedClean()
{
    QPushButton * button = (QPushButton*)sender();
    QString digit = button->text();
    QString display = ui->display->text();
    if (display =="c")
    {
      QString setText = "";
    }

}
void MainWindow::returnNumbersFloat()
{
    QPushButton *button = (QPushButton*)sender();
    QString digit = button->text();

}
void MainWindow::returnProcent()
{
    QPushButton *button = (QPushButton*)sender();
    QString digit = button->text();
    QString display = ui->display->text();
    if (operation=="%")
    {

    }
}
