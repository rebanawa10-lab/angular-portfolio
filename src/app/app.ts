import { Component, signal } from '@angular/core';
// import { RouterOutlet } from '@angular/router'; // OLD: 

@Component({
  selector: 'app-root',
  // imports: [RouterOutlet],   // OLD: Cause to display the app.html twice
  imports: [],                  //  NEW: 
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angular-portfolio');

 
}
