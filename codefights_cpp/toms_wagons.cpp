#include <iostream>
using namespace std;

int toms_wagons(int e, int q, int n) {
  int d[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
  int s = 0;

  while(n--)
  {
    s += 1 + 2 * (q - 1);
    q += 1;
    if(q > d[e - 1]) {
      e = e % 12 + 1;
      q = 1;
    }
  }
  return s;
}
