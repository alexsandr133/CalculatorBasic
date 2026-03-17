#include "dialog.h"
#include <QPushButton>
#include <QVBoxLayout>
Dialog::Dialog(QWidget *parent): QDialog(parent)
{
    setWindowTitle("Ввод данных");
    resize(300, 120);

    lineEdit = new QLineEdit(this);
    QPushButton *btn = new QPushButton("отправить", this);

    QVBoxLayout *layot = new QVBoxLayout(this);
    layot ->addWidget(lineEdit);
    layot->addWidget((btn));

    connect(btn, &QPushButton::clicked, this, &Dialog::onSendClicked);

}
void dialog::onSendClicked()
{
    emit dataSend(lineEdit->text());
    accept();
}
