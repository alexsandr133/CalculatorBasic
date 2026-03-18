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
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralwidget;
    QWidget *gridLayoutWidget;
    QGridLayout *gridLayout_2;
    QPushButton *button_3;
    QPushButton *button_9;
    QPushButton *button_8;
    QPushButton *button_2;
    QPushButton *button_7;
    QPushButton *button_6;
    QPushButton *button_5;
    QPushButton *button_4;
    QPushButton *equalButton;
    QPushButton *button_1;
    QPushButton *button_minus;
    QPushButton *button_plus;
    QPushButton *button_0;
    QPushButton *button_mulnition;
    QPushButton *button_delenie;
    QLabel *display;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName("MainWindow");
        MainWindow->resize(953, 941);
        MainWindow->setStyleSheet(QString::fromUtf8("font: 48pt \"Segoe UI\";"));
        centralwidget = new QWidget(MainWindow);
        centralwidget->setObjectName("centralwidget");
        gridLayoutWidget = new QWidget(centralwidget);
        gridLayoutWidget->setObjectName("gridLayoutWidget");
        gridLayoutWidget->setGeometry(QRect(0, 270, 801, 491));
        gridLayout_2 = new QGridLayout(gridLayoutWidget);
        gridLayout_2->setObjectName("gridLayout_2");
        gridLayout_2->setContentsMargins(0, 0, 0, 0);
        button_3 = new QPushButton(gridLayoutWidget);
        button_3->setObjectName("button_3");

        gridLayout_2->addWidget(button_3, 1, 2, 1, 1);

        button_9 = new QPushButton(gridLayoutWidget);
        button_9->setObjectName("button_9");

        gridLayout_2->addWidget(button_9, 3, 2, 1, 1);

        button_8 = new QPushButton(gridLayoutWidget);
        button_8->setObjectName("button_8");

        gridLayout_2->addWidget(button_8, 3, 1, 1, 1);

        button_2 = new QPushButton(gridLayoutWidget);
        button_2->setObjectName("button_2");

        gridLayout_2->addWidget(button_2, 1, 1, 1, 1);

        button_7 = new QPushButton(gridLayoutWidget);
        button_7->setObjectName("button_7");

        gridLayout_2->addWidget(button_7, 3, 0, 1, 1);

        button_6 = new QPushButton(gridLayoutWidget);
        button_6->setObjectName("button_6");

        gridLayout_2->addWidget(button_6, 2, 2, 1, 1);

        button_5 = new QPushButton(gridLayoutWidget);
        button_5->setObjectName("button_5");

        gridLayout_2->addWidget(button_5, 2, 1, 1, 1);

        button_4 = new QPushButton(gridLayoutWidget);
        button_4->setObjectName("button_4");

        gridLayout_2->addWidget(button_4, 2, 0, 1, 1);

        equalButton = new QPushButton(gridLayoutWidget);
        equalButton->setObjectName("equalButton");

        gridLayout_2->addWidget(equalButton, 4, 2, 1, 1);

        button_1 = new QPushButton(gridLayoutWidget);
        button_1->setObjectName("button_1");
        button_1->setEnabled(true);

        gridLayout_2->addWidget(button_1, 1, 0, 1, 1);

        button_minus = new QPushButton(gridLayoutWidget);
        button_minus->setObjectName("button_minus");

        gridLayout_2->addWidget(button_minus, 4, 1, 1, 1);

        button_plus = new QPushButton(gridLayoutWidget);
        button_plus->setObjectName("button_plus");

        gridLayout_2->addWidget(button_plus, 4, 0, 1, 1);

        button_0 = new QPushButton(gridLayoutWidget);
        button_0->setObjectName("button_0");

        gridLayout_2->addWidget(button_0, 0, 0, 1, 1);

        button_mulnition = new QPushButton(gridLayoutWidget);
        button_mulnition->setObjectName("button_mulnition");

        gridLayout_2->addWidget(button_mulnition, 0, 1, 1, 1);

        button_delenie = new QPushButton(gridLayoutWidget);
        button_delenie->setObjectName("button_delenie");

        gridLayout_2->addWidget(button_delenie, 0, 2, 1, 1);

        display = new QLabel(centralwidget);
        display->setObjectName("display");
        display->setGeometry(QRect(20, 50, 741, 151));
        display->setStyleSheet(QString::fromUtf8("font-size: 48pt;"));
        MainWindow->setCentralWidget(centralwidget);
        menubar = new QMenuBar(MainWindow);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 953, 90));
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
        button_3->setText(QCoreApplication::translate("MainWindow", "3", nullptr));
        button_9->setText(QCoreApplication::translate("MainWindow", "9", nullptr));
        button_8->setText(QCoreApplication::translate("MainWindow", "8", nullptr));
        button_2->setText(QCoreApplication::translate("MainWindow", "2", nullptr));
        button_7->setText(QCoreApplication::translate("MainWindow", "7", nullptr));
        button_6->setText(QCoreApplication::translate("MainWindow", "6", nullptr));
        button_5->setText(QCoreApplication::translate("MainWindow", "5", nullptr));
        button_4->setText(QCoreApplication::translate("MainWindow", "4", nullptr));
        equalButton->setText(QCoreApplication::translate("MainWindow", "=", nullptr));
        button_1->setText(QCoreApplication::translate("MainWindow", "1", nullptr));
        button_minus->setText(QCoreApplication::translate("MainWindow", "-", nullptr));
        button_plus->setText(QCoreApplication::translate("MainWindow", "+", nullptr));
        button_0->setText(QCoreApplication::translate("MainWindow", "0", nullptr));
        button_mulnition->setText(QCoreApplication::translate("MainWindow", "*", nullptr));
        button_delenie->setText(QCoreApplication::translate("MainWindow", "/", nullptr));
        display->setText(QCoreApplication::translate("MainWindow", "0", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
