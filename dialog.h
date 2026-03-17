#ifndef DIALOG_H
#define DIALOG_H
#include "dialog.h"
#include "atsmedia.h"
#include <QDialog>
#include <QLineEdit>
class Dialog
{
     Q_OBJECT
public:
     explicit Dialog(QWidget *parent = nullptr);
signals:
     void dataSend(const QString &text);
private slots:
     void onSendClicked();
    void recieveData(const QString &text);
private:
     QLineEdit lineEdit;
};

#endif // DIALOG_H
