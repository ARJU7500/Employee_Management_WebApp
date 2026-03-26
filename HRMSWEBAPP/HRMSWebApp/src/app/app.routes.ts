import { Routes } from '@angular/router';
import { Dashboard } from './Components/dashboard/dashboard';
import { Login } from './Components/login/login';
import { EMployeeForm } from './Components/employee-form/employee-form';
import { Department } from './Components/department/department';
import { EMployeeList } from './Components/employee-list/employee-list';
import { Desigation } from './Components/desigation/desigation';

export const routes: Routes = [
    {path: '',component: Login},
    {path:'login',component:Login},
    {path:'dashboard',component:Dashboard},
    {path:'new-employee',component:EMployeeForm},
    {path:'employees',component:EMployeeList},
    {path:'department',component:Department},
    {path:'designation',component:Desigation},
];
