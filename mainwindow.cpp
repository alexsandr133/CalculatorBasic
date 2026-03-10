#include "mainwindow.h"
#include "ui_mainwindow.h"
double firstNumber = 0;
double secondNumber = 0;

QString currentoperation= " ";
bool isWaitiongForSecondNumber = false;
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
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

    connect(ui->button_plus, &QPushButton::clicked, this, &MainWindow::operationPresssed);
    connect(ui->button_minus, &QPushButton::clicked, this, &MainWindow::operationPresssed);

    connect(ui->equalButton, &QPushButton::clicked, this, &MainWindow::calculate);


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
    isWaitiongForSecondNumber = true;
    ui->display->setText("0");
}
void MainWindow::calculate()
{
    secondNumber = ui->display->text().toDouble();
    double result = 0;
    if (operation =="+")
    {
        result = firstNumber + secondNumber;
    }
    else if(operation=="-")
    {
        result = firstNumber - secondNumber;
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
