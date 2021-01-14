#include<iostream>
#include<string>
#include"Revision.h"

using namespace std;

// Etudiant ;

void Etudiant::Saisir()
{
	cout << " Matricule : ";
	cin >> Matricule;
	cout << " Nom : ";
	cin >> Nom;

	for (int i = 1; i <= NbrNotes; i++)
	{
		cout << " Note " << i << " : ";
		cin >> TabNotes[i];
	}

}

void Etudiant::Afficher()
{
	cout << " Je suis un Etudiant " << endl;

	//cout << " Nom : " << Nom << endl;
	//cout << " Matricule : " << Matricule << endl;
	//
	//for (int i = 1; i <= NbrNotes; i++)
	//{
	//	cout << " Note [" << i << "] : " << TabNotes[i] << endl; // Note[1] : 20 
	//}

	//cout << " et la Moyenne est  : " << Moyenne() << endl;

}

double Etudiant::Moyenne()
{
	double S = 0;

	for (int i = 1; i <= NbrNotes; i++)
	{
		S += TabNotes[i];
	}

	return (S / NbrNotes);

}

bool Etudiant::Comparer(Etudiant& E1, Etudiant& E2)
{
	if (E1.Moyenne() == E2.Moyenne())
		return true;
	else
		return false;

}

// Etudiant chercheur;

void EtudiantChercheur::Saisir()
{
	cout << " Matricule : ";
	cin >> Matricule;
	cout << " Nom : ";
	cin >> Nom;

	for (int i = 1; i <= NbrNminip; i++)
	{
		cout << " Note " << i << " : ";
		cin >> TabNminip[i];
	}

}

void EtudiantChercheur::Afficher()
{
	cout << " Je suis un etudiant chercheur " << endl;
	//cout << " Nom : " << Nom << endl;
	//cout << " Matricule : " << Matricule << endl;

	//for (int i = 1; i <= NbrNminip; i++)
	//{
	//	cout << " Note [" << i << "] : " << TabNminip[i] << endl; // Note[1] : 20  
	//}

	//cout << " et la Moyenne est  : " << Moyenne() << endl;
}

double EtudiantChercheur::Moyenne()
{
	double MoyEtudiant = Etudiant::Moyenne(),MoyMini = 0, S = 0;

	for (int i = 1; i <= NbrNminip; i++)
	{
		S += TabNminip[i];
	}

	MoyMini = (S / NbrNminip);

	return( (MoyEtudiant + MoyMini) / 2);

}

int main()
{
	bool rep;

	Etudiant *E = new EtudiantChercheur();
	EtudiantChercheur *Ec = new EtudiantChercheur();

	E->Afficher();
	Ec->Afficher();





	delete E;
	delete Ec;

	return 0;
}