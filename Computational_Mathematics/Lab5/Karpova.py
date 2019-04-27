import numpy as np
import scipy as sp
import array as arr

def analyticEval (x,t):
    return (-(1/2)*np.exp(-t)*(2*np.exp(t)*t-2*x-np.exp(t)*x**2))
L = 10
#Analytic solution
trail=[0,0,0,0,0,0,0,0,0,0,0]
print("Analytic solution:")
for i in range(0,11,1):
    trail[i]=analyticEval(i/L,1)
print(trail)
L=10
T=0
K=1
H=1/(L+1)
DT=K*H
DTX=DT/H

u=[0,0,0,0,0,0,0,0,0,0,0]
for i in range(0,11,1):
    u[i]=1/L*(i)+0.5*(1/L*(i))**2
print(u)
while T+DT<=1:
    for l in range(10,3,-1):
        x=l/L
        u[l] = u[l]+DTX/(6*H)*(np.exp(T)-DTX/2*(1-DTX/3)*x+x)*(2*u[l-3]-9*u[l-2]+18*u[l-1]-11*u[l])+DTX**2/(2*H**2)*(x+np.exp(T))*(x+np.exp(T)-DTX*x)*(-u[l-3]+4*u[l-2]-5*u[l-1]+2*u[l])-(DTX**3*(x+np.exp(T)))/(6*H**3)*(-u[l-3]+3*u[l-2]-3*u[l-1]+u[l])+DTX*(x(x+np.exp(T))-DTX/2*(np.exp(2*T)+2*x*np.exp(T)+2*x**2)+(DTX**2*x)/6*(4*x+3*np.exp(T))
    T = T+DT
    u[2]=-T+2*np.exp(-T)*H+2*H**2
    u[1]=-T+np.exp(-T)*H+H**2/2
    u[0]=-T
    DT=K*H/np.exp(T)
    DTX=DT/H
DT=1-T
DTX=DT/H
for l in range(10,3,-1):
    x=l/L
        u[l] = u[l]+DTX/(6*H)*(np.exp(T)-DTX/2*(1-DTX/3)*x+x)*(2*u[l-3]-9*u[l-2]+18*u[l-1]-11*u[l])+DTX**2/(2*H**2)*(x+np.exp(T))*(x+np.exp(T)-DTX*x)*(-u[l-3]+4*u[l-2]-5*u[l-1]+2*u[l])-(DTX**3*(x+np.exp(T)))/(6*H**3)*(-u[l-3]+3*u[l-2]-3*u[l-1]+u[l])+DTX*(x(x+np.exp(T))-DTX/2*(np.exp(2*T)+2*x*np.exp(T)+2*x**2)+(DTX**2*x)/6*(4*x+3*np.exp(T))
u[2]=-1+2*np.exp(-1)*H+2*H**2
u[1]=-1+np.exp(-1)*H+H**2/2
u[0]=-1
diff=u-trail
print(max(diff))
a = ""
input(a)
