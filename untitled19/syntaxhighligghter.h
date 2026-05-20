#ifndef SYNTAXHIGHLIGGHTER_H
#define SYNTAXHIGHLIGGHTER_H
#include <QSyntaxHighlighter>
#include <QWidget>

namespace Ui {
class SyntaxHighLigghter;
}

class SyntaxHighLigghter : public   QSyntaxHighlighter
{
    Q_OBJECT
private:
    QString Listkeyword;
    /*
     * класс QSyntaxHighLighter импортирует следующее:
     * NormalStae, insideCStyleComment
     * из класс SyntaxHighLIGHTER
     * также в коде на main.cpp описана логика кода
     * документа там есть QPallete и данный класс позволяет нам добавить в синтаксис подстветку
     *
    */
protected:
    enum {NormalState = -1, InsideCStyleCommen, InsideCSstring};
    //перегружаем метод
    virtual void highLightBlock(const QString);

    //метод для определения является ли введенный символ синтаксисом с++ или qt
    QString getKeyword(int i, const QString str) const;

public:
    explicit SyntaxHighLigghter(QTextDocument *parent = 0);
    ~SyntaxHighLigghter();

private:
    Ui::SyntaxHighLigghter *ui;
};

#endif // SYNTAXHIGHLIGGHTER_H
