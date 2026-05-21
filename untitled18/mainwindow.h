#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui {
class MainWindow;
}
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

private:
    Ui::MainWindow *ui;
public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();
signals:
    void digtalEntered();
    void OperationSave();
private slots:
    void digitalEntered();
    void OperationSaved();

};
#endif // MAINWINDOW_H
