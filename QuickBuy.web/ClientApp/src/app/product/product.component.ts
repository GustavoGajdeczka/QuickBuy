import { Component, OnInit } from "@angular/core"
import { Product } from "../model/product"
import { ProductService } from "../services/product/product.service";

@Component({
  selector: "product",
  templateUrl: "./product.component.html",
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  public product: Product;
  public selectedFile: File;
  public selectedPhotoMessage: string = "Escolha uma foto";
  public active_spinnner: boolean;

  constructor(private productService: ProductService) {

  }

  ngOnInit(): void {
    this.product = new Product();
  }

  public inputChange(files: FileList) {
    this.selectedFile = files.item(0);
    this.active_spinnner = true;
    this.productService.sendFile(this.selectedFile)
      .subscribe(fileName => {
        this.product.fileName = fileName;
        this.active_spinnner = false;
      }, e => {
          //alert(e.error);
          this.active_spinnner = false;
      });
    this.selectedPhotoMessage = this.selectedFile.name;
  }

  public register() {
    /*this.productService.register(this.product)
      .subscribe(
        productJson => {
          
        }, e => {
          alert(e.error);
        }
      );*/
  }
}
