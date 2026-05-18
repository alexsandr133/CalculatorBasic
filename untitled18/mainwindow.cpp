#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QTextEdit>
#include <QStatusBar>

//статус веденного текста
bool isSymbalEntered = false;
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}
//сигналы методов
//пользователь вводит текст ии он менеятся
connect(ui->CodeConsole,&QTextEdit::textChanged(),this, &MainWindow::onTextChanged);

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
void operationEnter()
{
    QTextEdit *CodeConsole = (QTextEdit)QString();
    if (isSymbolEntered = true)
    {
        QString operation = QText ->text();
    }
}
