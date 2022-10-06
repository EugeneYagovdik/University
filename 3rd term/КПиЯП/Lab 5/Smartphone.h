#pragma once
#include "Portative.h"

class Smartphone : public Portative
{
protected:

	string type;
	int camres;

public:

	Smartphone();

	explicit Smartphone(int yr, double pr, const char* br, const char* nm, int bat, int tm, double sz, int res);

	~Smartphone() {};

	void setcamres(int nusb);

	int getcamres();

	void table();

	friend istream& operator>>(istream& stream, Smartphone& c);
	friend ostream& operator<<(ostream& stream, Smartphone& c);
};