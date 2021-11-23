import { ToastrService } from 'ngx-toastr';
import { TableService } from './../../../services/table.service';
import { FormGroup, ReactiveFormsModule, FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { BehaviorSubject, Subscription } from 'rxjs';

@Component({
  selector: 'app-add-table',
  templateUrl: './add-table.component.html',
  styleUrls: ['./add-table.component.scss']
})
export class AddTableComponent implements OnInit {
  isLoading$: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  isLoading: boolean;
  private unsubscribe: Subscription[] = [];
  tableAddForm: FormGroup;
  constructor(private formBuilder:FormBuilder,private tableService:TableService,private toastrService:ToastrService) {
    const loadingSubscr = this.isLoading$
    .asObservable()
    .subscribe((res) => (this.isLoading = res));
    this.unsubscribe.push(loadingSubscr);
   }

  ngOnInit(): void {
    this.createTableAddForm();
  }

  createTableAddForm(){
    this.tableAddForm = this.formBuilder.group({
      tableName: ['', Validators.required],
      tableStatus: [false, Validators.required]
    });
  }
  addTable(){
    console.log(this.tableAddForm);

    if (this.tableAddForm.valid) {
      let tableModel = Object.assign({}, this.tableAddForm.value);
      this.tableService.addTable(tableModel).subscribe(
        (response) => {
          this.toastrService.success(response.message,"Başarılı")
          console.log(response.message);
        },
        (responseError) => {
          /*if(responseError.error.Errors.lenght > 0){
            for (let i = 0; i < responseError.error.Errors.length; i++) {
              this.toastrService.error(responseError.error.Errors[i].ErrorMessage, 'Hata');
              console.log(responseError);
            }
          }*/
          this.toastrService.error(responseError.error.message,"Hata");
        }
      );

    }else{
      this.toastrService.error("Eksik alanları doldurun","Hata");
      console.log("Hata");

    }
  }

}
