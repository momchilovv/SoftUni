function search(){
    let searchText = $('#searchText').val();
    let matchedItems = $(`#towns li:contains('${searchText}')`);
    $('#towns li').css('font-weight', '');
    matchedItems.css('font-weight', 'bold');
    $('#result').text(matchedItems.length + ' matches found.');
};