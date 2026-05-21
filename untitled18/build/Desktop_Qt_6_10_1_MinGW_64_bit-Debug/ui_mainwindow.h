/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 6.10.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralwidget;
    QTextEdit *CodeConsole;
    QPushButton *savebutton;
    QPushButton *shareitbutton;
    QLabel *label;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName("MainWindow");
        MainWindow->resize(800, 600);
        centralwidget = new QWidget(MainWindow);
        centralwidget->setObjectName("centralwidget");
        CodeConsole = new QTextEdit(centralwidget);
        CodeConsole->setObjectName("CodeConsole");
        CodeConsole->setGeometry(QRect(150, 10, 591, 521));
        savebutton = new QPushButton(centralwidget);
        savebutton->setObjectName("savebutton");
        savebutton->setGeometry(QRect(20, 10, 111, 21));
        savebutton->setStyleSheet(QString::fromUtf8("button-color:(0, 85, 0);\n"
"font: 500 italic 11pt \"Source Code Pro\";"));
        shareitbutton = new QPushButton(centralwidget);
        shareitbutton->setObjectName("shareitbutton");
        shareitbutton->setGeometry(QRect(20, 40, 111, 20));
        shareitbutton->setStyleSheet(QString::fromUtf8("button-color:rgb(1, 85, 0)"));
        label = new QLabel(centralwidget);
        label->setObjectName("label");
        label->setGeometry(QRect(170, 10, 121, 16));
        label->setStyleSheet(QString::fromUtf8("font: 500 italic 11pt \"Source Code Pro\";\n"
"font-color: greenrgb(100, 85, 55);"));
        MainWindow->setCentralWidget(centralwidget);
        menubar = new QMenuBar(MainWindow);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 800, 21));
        MainWindow->setMenuBar(menubar);
        statusbar = new QStatusBar(MainWindow);
        statusbar->setObjectName("statusbar");
        MainWindow->setStatusBar(statusbar);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QCoreApplication::translate("MainWindow", "MainWindow", nullptr));
        savebutton->setText(QCoreApplication::translate("MainWindow", "\321\201\320\276\321\205\321\200\320\260\320\275\320\270\321\202\321\214", nullptr));
        shareitbutton->setText(QCoreApplication::translate("MainWindow", "\320\276\321\202\320\277\321\200\320\260\320\262\320\270\321\202\321\214", nullptr));
        label->setText(QCoreApplication::translate("MainWindow", "\320\262\320\262\320\265\320\264\320\270\321\202\320\265 \321\202\320\265\320\272\321\201\321\202", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
