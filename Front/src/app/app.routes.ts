import { Routes } from '@angular/router';
import { HomePage } from './pages/home/home.page';
import { DashboardComponent } from './pages/home/components/dashboard/dashboard.component';
import { QuizDetailsPage } from './pages/quiz-details/quiz-details.page';

export const routes: Routes = [
    { path : '', component: HomePage },
    { path : 'quiz/:id', component: DashboardComponent},
    { path : 'details/:id', component: QuizDetailsPage}
];
