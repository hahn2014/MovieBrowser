//
//  ViewController.swift
//  Movie Browser
//
//  Created by Bryce Hahn on 8/17/16.
//  Copyright © 2016 Hahn2014 Studios. All rights reserved.
//

import UIKit

class ViewController: UIViewController, UISearchBarDelegate, UITableViewDelegate {
    
    @IBOutlet weak var SearchBarView: UISearchBar!
    @IBOutlet weak var TableView: UITableView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        //attatch all objects to view
        SearchBarView.delegate = self;
        TableView.delegate = self;
        
    }
    
    
    /************
     *SEARCH BAR*
     *SEARCH BAR*
     *SEARCH BAR*
     ************/
    func searchBarShouldBeginEditing(_ searchBar: UISearchBar) -> Bool {
        searchBar.showsCancelButton = true; //show cancel button
        return true;
    }
    
    func searchBarSearchButtonClicked(_ searchBar: UISearchBar) {
        searchBar.showsCancelButton = false//hide cancel button
        searchBar.resignFirstResponder(); //retract keyboard and loose searchbar focus
        
        //search for shit here
    }
    
    func searchBarCancelButtonClicked(_ searchBar: UISearchBar) {
        searchBar.showsCancelButton = false//hide cancel button
        searchBar.resignFirstResponder(); //retract keyboard and loose searchbar focus
    }
}
