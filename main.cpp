#include "mainwindow.h"

#include <QApplication>
#include <QWidget>
#include <qLabel>
#include <QVBoxLayout>
#include <QPushButton>
int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    QWidget widget;
    widget.setWindowTitle("qt app title");
    widget.setMinimumWidth(300);
    widget.setMinimumHeight(150);

    QLabel label(&widget);
    label.setText("michael");
    QLabel label1(&widget);
    label1.setText("se santa");
    QLabel label2(&widget);
    label2.setText("2026");

    QVBoxLayout *layout = new QVBoxLayout(&widget);
    layout ->addWidget(&label);
    layout ->addWidget(&label1);
    layout ->addWidget(&label2);
    QPushButton btn{"click", &widget};
    widget.show();
    return a.exec();
}
