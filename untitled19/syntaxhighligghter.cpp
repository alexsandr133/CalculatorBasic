#include "syntaxhighligghter.h"
#include "ui_syntaxhighligghter.h"
#include <QtGui>

SyntaxHighLigghter::SyntaxHighLigghter(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::SyntaxHighLigghter)
{
    ui->setupUi(this);
}

SyntaxHighLigghter::~SyntaxHighLigghter()
{
    delete ui;
}
SyntaxHighLigghter::SyntaxHighLigghter(QTextDocument* parent/*= 0*/)
    : QSyntaxHighlighter(parent)
{
    Listkeyword
    {
        QString CodeWords = {
            "foreach",
            "float",

    }
    }





}
