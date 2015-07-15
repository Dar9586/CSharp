/*****************************************************************************
** Sample Test file
******************************************************************************/

// Defines
#define CONSTANT_V1     0x0001
#define CONSTANT_V2     1
#define CONSTANT_V3     CONSTANT_V1

// Prototypes
void Function1(void);
void Function2();

// function with param
void Function3(int x, int y);
void Function4(UINT x, long y);
void Function5(int* x);
void Function6(int x[], int y);

// string parameter
void Function7(char* text, unsigned int size);
void Function8(wchar_t* text, unsigned int size);
void Function9(const char* text, unsigned int size);
void Function10(const wchar_t* text, unsigned int size);

// return value
int  Function11();
int  Function12(void);
double Function13(const char* label, int len);
const wchar_t* Function14(wchar_t* buffer, int size, const char* text, int len);

// passing arrays
long Function15(double points[], int numpoints);

// Structures
struct STRUCT1 {
  int size;
  int buffer[80];
};

struct STRUCT2
{
  unsigned int size;
  unsigned char buffer[128];
};

// struct string type
struct STRUCT3
{
  int  size;
  const char buffer[80];
};

typedef struct STRUCT4_
{
  int size;
} STRUCT4;
