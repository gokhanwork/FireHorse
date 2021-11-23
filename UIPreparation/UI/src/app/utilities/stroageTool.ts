import { environment } from "src/environments/environment";
import { AuthModel } from "../modules/auth/models/auth.model";

export class StroageTool{

  private authLocalStorageToken = `${environment.appVersion}-${environment.USERDATA_KEY}`;

  public getAuthFromLocalStorage(): AuthModel {
    try {
      const lsValue = localStorage.getItem(this.authLocalStorageToken);
      console.log("Straoge get "+lsValue);

      if (!lsValue) {
        return undefined!;
      }

      const authData = JSON.parse(lsValue);
      console.log("Strogae data ", authData);

      return authData;
    } catch (error) {
      console.log(error);

      return undefined!;
    }
  }

}
